var myApp = angular.module("myApp", []);

myApp.controller("myCtrl", function ($scope, $http) {

    $scope.pruebas = [];

    $scope.autos = [];
    $scope.auto = { id: '', modelo: '', cod_marca: '', cod_chasis: '', precio: '', fecha_llegada: '' };
    $scope.mostrar = 'L';
    $scope.buscarMarcas = function () {
        $http.get("api/marcas").then(function (respuesta) {
            $scope.marcas = respuesta.data;
        });
    }
    $scope.buscarMarcas();

    $scope.buscarAutos = function () {
        $http.get("api/autos").then(function (respuesta) {
            $scope.autos = respuesta.data;
        })
    }
    $scope.buscarAutos();

    $scope.limpiarCampos = function () {
        $scope.buscarAutos();
        $scope.auto.modelo = "";
        $scope.auto.cod_marca = "";
        $scope.auto.cod_chasis = "";
        $scope.auto.precio = "";
        $scope.auto.fecha_llegada = "";
        $scope.mostrar = "L";
    }

    $scope.cargar = function () {
        if ($scope.frmCarga.$valid) {
            if ($scope.mostrar == 'M') {
                $http.put("api/autos", $scope.auto).then(function successCallback(respuesta) {
                    alert("Modificacion exitosa");
                    $scope.limpiarCampos();
                }, function errorCallback(respuesta) {
                    console.log(respuesta);
                    alert("El codigo de chasis ya esta usado");
                });
            }
            else if ($scope.mostrar == 'A') {
                $http.post("api/autos", $scope.auto).then(function successCallback(respuesta) {
                    alert("Auto cargado con exito");
                    $scope.limpiarCampos();
                }, function errorCallback(respuesta) {
                    console.log(respuesta);
                    alert("El codigo de chasis ya esta usado");
                });
            }
        }
        else
            alert("Algun campo no fue cargado correctamente")
    }

    $scope.llenarForm = function (auto) {
        if (confirm("Desea modificar a " + auto.modelo)) {
            $scope.auto.modelo = auto.modelo;
            $scope.auto.cod_marca = auto.cod_marca;
            $scope.auto.cod_chasis = auto.cod_chasis;
            $scope.auto.fecha_llegada = new Date(auto.fecha_llegada);
            $scope.auto.precio = auto.precio;
            $scope.auto.id = auto.id;
            $scope.mostrar = "M";
        }
    }

    $scope.eliminar = function (auto) {
        if (confirm("Desea eliminar a " + auto.modelo)) {
            console.log(auto.id);
            $http.delete("api/autos/" + auto.id).then(function (respuesta) {
                alert("Auto eliminado exitosamente");
                $scope.buscarAutos();
            })
        }
    }

    $scope.BIncremental = function () {
        $http.get("api/autos/" + $scope.incremental).then(function successCallback(respuesta) {
            $scope.autos = respuesta.data;
        })
    }

    $scope.encontrarMarca = function (id) {
        if ($scope.marcas.cod_marca == 0) {
            return id;
        } else {
            var busqueda = $scope.marcas.find(function (item) {
                return item.cod_marca === id;
            });
            return busqueda.nombre;
        }
    }
});

myApp.config(['$qProvider', function ($qProvider) {
    $qProvider.errorOnUnhandledRejections(false);
}]);

