using SolorFrontAndBack.Models;
using System.Collections.Generic;

namespace SolorFrontAndBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> sliders { get; set; }
        public About about { get; set; }
        public IEnumerable<Services> services { get; set; }
        public IEnumerable<Team> team { get; set; }
        public IEnumerable<Team2> team2 { get; set; }


    }
}
