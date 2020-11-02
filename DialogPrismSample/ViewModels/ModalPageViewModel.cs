using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DialogPrismSample.ViewModels
{
    public class ModalPageViewModel : BindableBase
    {
        public DelegateCommand ShowDialogCommand { get; set; }

        public ModalPageViewModel(IDialogService dialogService)
        {
            ShowDialogCommand = new DelegateCommand(async () =>
            {
                var param = new DialogParameters();
                param.Add("Message", "I'm a dialog");
                dialogService.ShowDialog("DialogView", param, CloseDialogCallback);
            });
        }

        private void CloseDialogCallback(IDialogResult dialogResult)
        {
        }
    }
}