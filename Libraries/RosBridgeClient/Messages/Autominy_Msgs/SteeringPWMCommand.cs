using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_SteeringPWMCommand : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/SteeringPWMCommand";
        public Standard.Header header;
        public int value;

        public Autominy_SteeringPWMCommand()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}