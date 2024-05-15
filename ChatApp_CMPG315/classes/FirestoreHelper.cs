using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_CMPG315.Classes
{
    internal static class FirestoreHelper
    {
        static string fireConfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""text-message-cmpg-315-poject"",
          ""private_key_id"": ""d06863b57e5759233ef87537b6e38f70f55731b0"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDQYAnzOuwQi4x7\nROZucYjAVtuoIiOJGbTKQYIphTlUACGp53P51NEkfvZ10z7VBX7WoGc7NnTWUo+E\n8rCnWyZt20oy9dLn2dFIflubpoOcUvn7N7UutHa5WxodQ6NFnj9XYLPHrVos+Qh1\nFrKYllHFCOrHHzPooU7RY9kSTn2vAhcQJKcMfrBdBPXgwxLJJE7+6yAzEbxmuWfM\nj6OGLyKrY6QascLerWOfjYHpezvefbLZ4rfkxEWCpnZ3u7Kzhp5qJOm4nx7FSHVQ\nDi+C1V49hWKbq/GqnVu1Bi+s3MCsVEaXbuzn0G/i/wPtXCmhFtBDawIvmJf02dmb\nE6jszRgHAgMBAAECggEAINWxW7GCN002EsqVoPuk9+H39POEM/toAKL39sD2eqUW\nqOY+4TRGzIBxJ7nk4b5e8UUPX0ZCfO8/jEyNx6FWWeM/Ou5/kGdDUjAPEWTYwk5U\n8+AgXb60IpsXb1sUJEk+Y+9qBOHtHr8TNRghhmfRdMHl9QCWtmaMu/QG5ZqWtXfP\nDU0NQxAWMje7c7yXqUyHe9E43l8BRxgd4xj36H8hHhyynX0Ff2ponp0NjG5lPHvR\nHt9EwkVd2iQKZwKqZDgxUD9+CjzHp1+QE8ZwBEH7Kgj5H1eGi+7jZbvHsrmuyU+Z\nzOWRUHx2pQC4n3mZbQiwTEt5aWzNJgoOz+DjiS5pSQKBgQDpmssWYkUCvk7NOxdU\nrJ7ymFYdL/mPgqmijpJMJGAvvKrH8kw/mQfuGPUh6fMvWZU2Tg/RNUMm55dh9N7E\nGUfoy4RbrS9jQzqd6MCPMTNnQIhenOYJ+5Zk6NFSoWRn+w1etDCjluj65KuAvjCl\nnAJPvPsKtqoQc2wFv+gORPrTswKBgQDkWg3egDLazbBwzCSUvZj/4M0Rf8nGdWqy\nyyTbAI8G1Rguk/EggBPFXzAuYfJaoi7flmY1c+6vgwpoACWaxIVrnMXUudWR6FrA\ncK+GUoZwKIo2SPn3KmsBfcS6+L6i79X2bTyYcUKBU7dynr3TOySVBsC832464rKM\nJFsj0EEQXQKBgA+F9MbpAtL62Hu02IkM64cNbnOEE55gvWsK9FfQ9v9VFzgwNrbn\nMWq2B9wYEsvrtQmlyFFLq8mzDBE7V25Ki8fBdmstJ//9oLCLnfgl+dd7p1Q6MuMo\n78aG3hoSlXx/Z1UKvkywo4zAk1D70nm+0zx/P2Nn3gc31E7RgNcp6E0XAoGBAOGD\nFgNQs+hmDgO3d8D05S5+AcdwXgKCXtcny8QEbzueIv2M2SrxkZTwBpMn48IiPQxO\naa4MSgJG9XXz/y8zOVgnQTBuPj6UK1u1bYLH6UDGqIgn1cSEvZyBalID6bDcDoAJ\nLTiXUciKtraZknoTBHOwcZOVTDUXQKEqHl/mAPt5AoGBANtbWzG50ydXZY/LLQ2F\nUsZnq1uJqj3suMiybYkehLfH6kNRLpm6+oITuMoxS9Yo+QGP30k6BRSloJFjMLKM\nc0B8plna/m7xS1AA16VpT+YC5FUicbGi8y9sRWiJqVgbQBIZZAuso/gHBhM0FrrD\nvA9FhMzyDwx7yltQfLiISGAO\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-3hbqs@text-message-cmpg-315-poject.iam.gserviceaccount.com"",
          ""client_id"": ""106009612294440625282"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-3hbqs%40text-message-cmpg-315-poject.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }";

        static string firepath = "";
        public static FirestoreDb Database { get; private set; }

        public static void setEnvironmentVariable()
        {
            var filePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filePath, fireConfig);
            File.SetAttributes(filePath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            Database = FirestoreDb.Create("text-message-cmpg-315-poject");
            //Do: Delete the file using the filePath
            File.Delete(filePath);
        }
    }
}