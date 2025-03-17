using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BloggingApp_Client
{

    public class PostService
    {
        static HttpClient client = new HttpClient();
        private readonly HttpClient _httpClient;
        public PostService()
        {
            // Initialize the HttpClient instance
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8083/") // Set the base URL for the API
            };
        }
        public async Task<HttpResponseMessage> PostAsync(string endpoint, HttpContent content)
        {
            // Ensure _httpClient is not null and send the POST request
            if (_httpClient == null)
                throw new InvalidOperationException("_httpClient is not initialized.");

            return await _httpClient.PostAsync(endpoint, content);
        }

        public void createConnection()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("http://localhost:8083/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            }
        }

        //Get (All) Posts Method
        public List<Post> getAllPosts()
        {
            List<Post> posts = null;
            HttpResponseMessage response = client.GetAsync("post").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Received: " + resultString);
                posts = JsonConvert.DeserializeObject<List<Post>>(resultString);
                return posts;
            }
            return null;
        }

        //Create Post Method
        public void createPost(Post newPost)
        {
            var json = JsonConvert.SerializeObject(newPost);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("post/create", content).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to create post");
            }
        }

        //Delete Post Method
        public async Task deletePost(int postId) // Make sure this returns Task
        {
            // Call the backend API to delete the post
            HttpResponseMessage response = await _httpClient.DeleteAsync($"post/{postId}");

            if (!response.IsSuccessStatusCode)
            {
                string error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to delete post: {error}");
            }
        }

        //Create User Method
        public void createUser(User newUser)
        {
            var json = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = client.PostAsync("user", content).Result;
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception in createUser: {e.Message}");
                throw new Exception("Failed to create user", e);
            }
        }

        //Get Active Users Method
        public List<User> getActiveUsers()
        {
            List<Post> posts = this.getAllPosts();
            return posts.Select(p => p.User).Where(u => u != null).Distinct(new UserComparer()).ToList();
        }
        public bool validateUser(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8083/");
                var query = $"user/validate?username={Uri.EscapeDataString(username)}&password={Uri.EscapeDataString(password)}";
                HttpResponseMessage response = client.GetAsync(query).Result;
                if (response.IsSuccessStatusCode)
                {
                    string resultString = response.Content.ReadAsStringAsync().Result;
                    return bool.Parse(resultString);
                }
                return false;
            }
        }

        // Get User by Username Method
        public User getUserByUsername(string username)
        {
            HttpResponseMessage response = client.GetAsync($"user/{username}").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<User>(resultString);
            }
            return null;
        }

        // Update Post Method
        public void updatePost(Post post)
        {
            var json = JsonConvert.SerializeObject(post);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"post/{post.postId}", content).Result;
            if ((!response.IsSuccessStatusCode))
            {
                throw new Exception("Failed to update post");
            }
        }

        // Method to fetch all users
        public async Task<List<User>> getAllUsers()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("user"); // Assuming this endpoint exists
                if (response.IsSuccessStatusCode)
                {
                    string resultString = await response.Content.ReadAsStringAsync();
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(resultString);
                    return users;
                }
                else
                {
                    throw new Exception("Failed to retrieve users");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching users: {ex.Message}");
            }
        }
    }

    internal class UserComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(User obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
