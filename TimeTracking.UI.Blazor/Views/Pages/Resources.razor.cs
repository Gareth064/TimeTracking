using AntDesign;
using Microsoft.AspNetCore.Components;
using TimeTracking.Core.Models;
using TimeTracking.UI.Blazor.Views.Components.Resources;

namespace TimeTracking.UI.Blazor.Views.Pages
{
    public partial class Resources
    {
        [Inject]
        public ModalService modalService { get; set; }
        public ModalRef AddResourceModalRef { get; set; }
        ResourcesTableComponent ResourcesTable;
        public Resource SelectedResource {  get; set; } 
        public async Task OpenAddResourceModalAsync()
        {
            var template = new Resource();
            var modalConfig = new ModalOptions();
            modalConfig.Title = "Add Resource";
            modalConfig.Mask = true;
            modalConfig.MaskClosable = false;
            modalConfig.Centered = true;
            modalConfig.Footer = null;

            modalConfig.OnCancel = async (e) => await AddResourceModalRef.CloseAsync();

            modalConfig.AfterClose = async () =>
            {
                this.StateHasChanged();
                await ResourcesTable.LoadResources();
            };

            AddResourceModalRef = await modalService
                .CreateModalAsync<AddResourceFormComponent, Resource>
                (modalConfig, template);

            AddResourceModalRef.OnOpen = () =>
            {
                Console.WriteLine("ModalRef OnOpen");
                return Task.CompletedTask;
            };

            AddResourceModalRef.OnOk = () =>
            {
                Console.WriteLine("ModalRef OnOk");
                return Task.CompletedTask;
            };

            AddResourceModalRef.OnCancel = () =>
            {
                Console.WriteLine("ModalRef OnCancel");
                return Task.CompletedTask;
            };

            AddResourceModalRef.OnClose = () =>
            {
                Console.WriteLine("ModalRef OnClose");
                return Task.CompletedTask;
            };
        }
    }
}