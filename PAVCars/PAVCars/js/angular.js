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
    }
});