namespace AppModel
{
    [NetDaemonApp]
    public class KLipperAppContext
    {
        public KLipperAppContext(IApplicationContext appCtx, ILogger<KLipperAppContext> logger)
        {
            logger.LogInformation("Hello from app with unique identity='{id}'", appCtx.Id);
        }
    }
}