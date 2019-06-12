var myApp = angular.module("myApp", []);

myApp.controller("myCtrl", function ($scope, $http) {

    $scope.autos = [];
    $scope.auto = { modelo: '', cod_marca: '', cod_chasis: '', precio: '', fecha_llegada: '' };
    $scope.mostrar = 'A';
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

    $scope.guardar = function () {
        if ($scope.frmAuto.$valid) {
            $http.post("api/autos", $scope.auto).then(function (respuesta) {
                alert("Auto cargado con exito");
                $scope.buscarAutos();
                $scope.auto.modelo = "";
                $scope.auto.cod_marca = "";
                $scope.auto.cod_chasis = "";
                $scope.auto.precio = "";
                $scope.auto.fecha_llegada = "";
            });
        }
        else
            alert("Algun campo no fue cargado correctamente")
    }

    $scope.modif = function (indice) {
        if ($scope.frmModif.$valid) {
            console.log($scope.auto);
            $http.put("api/autos", $scope.auto).then(function (respuesta) {
                console.log(respuesta);
                alert("Modificacion exitosa");
                $scope.buscarAutos();
            });
            $scope.auto.modelo = "";
            $scope.auto.cod_marca = "";
            $scope.auto.cod_chasis = "";
            $scope.auto.precio = "";
            $scope.auto.fecha_llegada = "";
            $scope.mostrar = "L";
        }
        else
            alert("Algun campo no fue cargado correctamente")
    }

    $scope.modificar = function (auto, indice) {
        if (confirm("Desea modificar a " + auto.modelo)) {
            $scope.auto.modelo = auto.modelo;
            $scope.auto.cod_marca = auto.cod_marca;
            $scope.auto.cod_chasis = auto.cod_chasis;
            $scope.auto.fecha_llegada = new Date(auto.fecha_llegada);
            $scope.auto.precio = auto.precio;
            $scope.indice = indice;
            $scope.mostrar = "M";
        }
    }

    $scope.eliminar = function (auto, indice) {
        if (confirm("Desea eliminar a " + auto.modelo)) {
            $http.delete("api/autos/" + auto.id).then(function (respuesta) {
                alert("Auto eliminado exitosamente");
                $scope.buscarAutos();
            })
        }
    }
});

myApp.config(['$qProvider', function ($qProvider) {
    $qProvider.errorOnUnhandledRejections(false);
}]);

