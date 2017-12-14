function ProductViewModel() {
    var self = this;
    self.Name = ko.observable('');
    self.Stock = ko.observable('');
    self.Table = $('#ProductTable').DataTable();

    self.GetDataFromServer = function () {
        $.get("/api/product")
        .then(function (products) {
            products.forEach(function (productItem) {
                self.Table.row.add([
                    productItem.Id,
                    productItem.Name,
                    productItem.Stock
                ]);
            })
            self.Table.draw();
        }).fail(function () {
            console.log('Error en el servicio')
        })
    }

    self.RegisterProduct = function () {
        var productData = {
            Name: self.Name(),
            Stock: self.Stock()
        }
        $.post("/api/product", productData)
        .then(function (registeredProduct) {
            self.Table.row.add([
                registeredProduct.Id,
                registeredProduct.Name,
                registeredProduct.Stock
            ]);
            self.Table.draw();
            ClearFormData();
        });
    }

    var ClearFormData = function () {
        self.Name('');
        self.Stock('');
    }
    return self;
}
