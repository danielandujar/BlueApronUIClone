using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace BlueApronUIClone.ViewModels
{
    public class DeliveryAddressPageViewModel : ViewModelBase
    {
        public DeliveryAddressPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}