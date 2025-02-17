﻿using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace PostApiService.Tests.E2ETests
{
    public class AuthControllerE2ETests
    {
        private readonly RestClient _client;

        public AuthControllerE2ETests()
        {            
            _client = new RestClient("https://localhost:7030/");
        }        

        [Fact]
        public async Task Login_ValidCredentials_ShouldReturnToken()
        {
            // Arrange
            var request = new RestRequest("/api/auth/login", Method.Post);
            request.AddJsonBody(new { Username = "admin", Password = "~Rtyuehe8" });

            // Act
            var response = await _client.ExecuteAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            Assert.Contains("token", result);
        }

        [Fact]
        public async Task Login_InvalidCredentials_ShouldReturnFailure()
        {
            // Arrange
            var request = new RestRequest("/api/auth/login", Method.Post);
            request.AddJsonBody(new { Username = "test", Password = "~Rtyuehe8" });

            // Act
            var response = await _client.ExecuteAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);           
        }

        [Fact]
        public async Task Login_InvalidPass_ShouldReturnFailure()
        {
            // Arrange
            var request = new RestRequest("/api/auth/login", Method.Post);
            request.AddJsonBody(new { Username = "admin", Password = "wrongpass" });

            // Act
            var response = await _client.ExecuteAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task Login_MissingUsername_ShouldReturnFailure()
        {
            // Arrange
            var request = new RestRequest("/api/auth/login", Method.Post);
            request.AddJsonBody(new { Username = "", Password = "~Rtyuehe8" });

            // Act
            var response = await _client.ExecuteAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
