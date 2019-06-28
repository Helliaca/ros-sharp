using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_NormalizedSpeedCommand : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/NormalizedSpeedCommand";
        public Standard.Header header;
        public float value;

        public Autominy_NormalizedSpeedCommand()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}