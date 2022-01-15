using meFamilyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meFamilyBackEnd.ViewModels
{
    public class HomeViewModel
    {
        public List<Story> Stories { get; set; }
        public List <Worker> Workers { get; set; }
        public List <Setting> Settings { get; set; }
        public List<SosialMedia> SosialMedias { get; set; }
        public List<WorkerSocialMedia> WorkerMedias { get; set; }
    }
}
