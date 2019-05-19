var myApp = angular.module("myApp", []);

myApp.controller("myCtrl", function ($scope, $http) {

    $scope.autos = [];
    $scope.mostrar = 'A';
    $scope.marcas = [{ nombre: "Ford", cod_marca: 1 }, { nombre: "Chevrolet", cod_marca: 2 }, { nombre: "Peugeot", cod_marca: 3 }, { nombre: "Fiat", cod_marca: 4 }];

    $scope.guardar = function () {
        if ($scope.frmAuto.$valid) {
            $scope.autos.push({ autoModelo: $scope.autoModelo, autoMarca: $scope.autoMarca, autoChasis: $scope.autoChasis, autoPrecio: $scope.autoPrecio, autoFecha: $scope.autoFecha });
            $scope.autoModelo = '';
            $scope.autoMarca = '';
            $scope.autoChasis = '';
            $scope.autoFecha = '';
            $scope.autoPrecio = '';
        }
        else
            alert("Algun campo no fue cargado correctamente")
    }

    $scope.modif = function (indice) {
        if ($scope.frmModif.$valid) {
            $scope.autos[indice] = { autoModelo: $scope.autoModelo, autoMarca: $scope.autoMarca, autoChasis: $scope.autoChasis, autoPrecio: $scope.autoPrecio, autoFecha: $scope.autoFecha };
            $scope.mostrar = 'L';
            $scope.autoModelo = '';
            $scope.autoMarca = '';
            $scope.autoChasis = '';
            $scope.autoFecha = '';
            $scope.autoPrecio = '';
            alert("Modificacion exitosa");
        }
        else
            alert("Algun campo no fue cargado correctamente")
    }

    $scope.modificar = function (auto, indice) {
        if (confirm("Desea modificar a " + auto.autoModelo)) {
            $scope.autoModelo = auto.autoModelo;
            $scope.autoMarca = auto.autoMarca;
            $scope.autoChasis = auto.autoChasis;
            $scope.autoFecha = auto.autoFecha;
            $scope.autoPrecio = auto.autoPrecio;
            $scope.indice = indice;
            $scope.mostrar = "M";
        }
    }

    $scope.eliminar = function (auto, indice) {
        if (confirm("Desea eliminar a " + auto.autoModelo)) {
            $scope.autos.splice(indice, 1);
            alert("Eliminado exitosamente");
        }
    }
});