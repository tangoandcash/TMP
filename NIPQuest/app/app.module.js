var app = angular.module("project", []);

app.controller('NIPController',['$scope','$http', function ($scope,$http) {
	
	$scope.NIP = undefined;
	$scope.Company = undefined;

   
	$scope.GetCompanyInfo = function () {
	
		console.log('GetCompanyInfo function init');

		var wywolanie = $http.get('Company/Details/'+$scope.NIP)
              .then(function (response) {
                  $scope.Company =response.data;
                  console.log('response data',response.data);
              	return response;
              })

		console.log(wywolanie);

		
	}

	$scope.SelectNIP = function(t)
	{
	    $scope.NIP = t;
	    console.log('t content', t);
	    console.log('scope nip', $scope.NIP);
	}
}]);