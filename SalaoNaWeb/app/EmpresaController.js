'use strict';
  
app.controller("EmpresaController", function ($scope, bootstrappedData) {
    $scope.empresas = bootstrappedData.empresas;
});
