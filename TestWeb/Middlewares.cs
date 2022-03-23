namespace TestWeb
{
    public static class Middlewares
    {

        public class CustomMW
        {
            RequestDelegate next;
            string kek;

            public CustomMW(RequestDelegate next, string kek)
            {
                this.next = next;
                this.kek = kek;
            }

            public async Task InvokeAsync(HttpContext context)
            {
                await context.Response.WriteAsync(kek);
            }
        }

    }
}
