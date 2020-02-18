using System;

namespace ToolHireClasses
{
    public class clsTools
    {
        public DateTime DateAdded { get; set; }
        public bool Active { get; set; }
        public int Cost { get; set; }
        public string ToolName { get; set; }
        public string Grade { get; set; }
        public int ToolId { get; set; }
        public bool ToolsNo { get; set; }

        public bool Find(int addressNo)
        {
            throw new NotImplementedException();
        }
    }
}