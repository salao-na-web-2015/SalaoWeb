function UserInfoViewModel(app, name, dataModel) {
    var self = this;

    // Dados
    self.name = ko.observable(name);

    // Operações
    self.logOff = function () {
        dataModel.logout().done(function () {
            app.navigateToLoggedOff();
        }).fail(function () {
            app.errors.push("Falha no fazer logoff.");
        });
    };

    self.manage = function () {
        app.navigateToManage();
    };
}
