var app = angular.module('app', []);

app.controller('HomeController', function ($scope, $http) {
	$scope.escreverPorExtenso = function() {
		var enderecoDaApi = "http://escreverporextenso.azurewebsites.net/api/porExtenso/" + $scope.numero;
		$http.get(enderecoDaApi).then(function(resposta) {
			$scope.numeroPorExtenso = resposta.data.numeroPorExtenso;
			$scope.numero = undefined;
		}, function(erro) {
			$scope.numeroPorExtenso = "Não foi possível escrever esse número";
		});
	};
});