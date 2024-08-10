angular.module("mainApp", [])
    .controller("loginController", function ($scope) { //$http

        console.log($scope.txtUsername);

        //$scope.credentials = {};
      
        ////Submit credentials
        //$scope.submitCredentials = function () {

        //    $http(
        //        {
        //            method: 'POST',
        //            url: '/Home/CheckAccount',
        //            data: $scope.credentials
        //        }).then(function (response) {
        //            //  debugger;
        //            console.log('success...');
        //        })
        //        .catch(function (response) {
        //            debugger;
        //            console.log('error...');
        //        });
        //}
    });

function show_hide_password(target)
{
    var input = document.getElementById('password-input');
    if (input.getAttribute('type') == 'password') {
        target.classList.add('view');
        input.setAttribute('type', 'text');
        
    } else {
        target.classList.remove('view');
        input.setAttribute('type', 'password');
    }
    return false;
}
