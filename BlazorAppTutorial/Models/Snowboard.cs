using CHHS.Common.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTutorial.Models
{
    public class Snowboard : BaseModel
    {
        public Snowboard()
        {

        }

        public int Size { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
}
