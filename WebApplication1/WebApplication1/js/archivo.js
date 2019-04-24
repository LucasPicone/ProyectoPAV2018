var miApp = angular.module("miApp", []);

miApp.controller("myCtrl", function ($scope, $http) {
    //$scope.paises = [{ name: "argentina", region: "sudamerica", population: "54000000" }, { name: "brasil", region: "sudamerica"}, { name: "urgay", region: "sudamerica", population: "5000000 canguros" }];
    $scope.mostrar = true;
    $scope.cargarPaises = function () {
        $scope.mostrar = false;
        $http({ method: 'GET', url: 'https://restcountries.eu/rest/v2/all' }).then(function successCallback(response) {
            $scope.mostrar = true;
            $scope.paises = response.data;
        }, function errorCallback(response) {
            $scope.mostrar = true;
            window.alert("rompiste todo flaque");
        });
    }
    $scope.poblacion = function (pais) {
        window.alert("La Poblacion es: " + pais.population)
    };
});