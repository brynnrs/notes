var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
 
app.MapGet("/", async context =>
{
  var html = @"
<!DOCTYPE html>
<html>
  <head>
    <title>Home Page</title>
  </head>
  <body>
    <form action='/submit' method='get'>
      <label for='name'>Enter your name:</label>
      <input type='text' id='name' name='name' required>
      <button type='submit'>Submit</button>
    </form>
  </body>
</html>
";
  await context.Response.WriteAsync(html);
});
 
app.MapGet("/submit", async context =>
{
  var name = context.Request.Query["name"].ToString() ?? "World";
 
  var html = $@"
<!DOCTYPE html>
<html>
  <head>
    <title>Submit Page</title>
  </head>
  <body>
    Hello {name}
  </body>
</html>
";
  await context.Response.WriteAsync(html);
});
 
app.Run();
 