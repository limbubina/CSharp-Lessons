using BinaSection15.EndExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection15
{
    internal class ComplicatedPage : BasePage
    {

        //Properties
        public SectionOfButtons ButtonSection { get; set; }
        public SectionOfSocialMedia SocialMediaSection { get; set; }
        public SectionOfRandomStuff RandomStuffSection { get; set; }

        //Override PageName properties
        public override string PageName { get => "Complicated Page"; }
        
    }
}
