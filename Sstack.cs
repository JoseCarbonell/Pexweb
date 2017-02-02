//Note: Using ServiceStack;

var client = new JsonServiceClient("<URL Api>");
var Items = client.Get<"Dto Class">("<To complete URL>");
