using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Standard
{
    public class UInt16 : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/UInt16";
        public int data;

        public UInt16()
        {
            data = 0;
        }
    }
}
