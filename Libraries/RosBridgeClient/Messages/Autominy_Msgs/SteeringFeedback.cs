using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_SteeringFeedback : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/SteeringFeedback";
        public Standard.Header header;
        public int value;

        public Autominy_SteeringFeedback()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}