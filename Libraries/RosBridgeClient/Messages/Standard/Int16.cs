using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Standard
{
    public class Int16 : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Int16";
        public int data;

        public Int16()
        {
            data = 0;
        }
    }
}
