var productViewModel = new ProductViewModel();
ko.applyBindings(productViewModel);
productViewModel.GetDataFromServer();