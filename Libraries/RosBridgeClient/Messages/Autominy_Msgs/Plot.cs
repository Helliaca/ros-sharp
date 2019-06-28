using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Autominy
{
   public class Autominy_Plot : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "autominy_msgs/Plot";
        public Standard.Header header;
        public float value;

        public Autominy_Plot()
        {
            header = new Standard.Header();
            value = 0;
        }
    }
}