//  translate it to angular js

window.onload = function () {

    var ctx = document.getElementById("grphAll4m").getContext('2d');
    var hwLineChart = new Chart(ctx, {
        type: 'pie',
        data: {
            labels: ["On-time","Due","Ongoing"],
            datasets: [{
                backgroundColor: [
                    'rgba(255, 99, 132, 0.8)',
                    'rgba(54, 162, 235, 0.8)',
                    'rgba(255, 206, 86, 0.8)',
                ],
                data: [10,3,4],
                borderWidth: 1,
                hoverBackgroundColor: "rgba(232,105,90,0.8)",
                hoverBorderColor: "orange",
                scaleStepWidth: 1
            }]
        },
        options: {
            legend: {
                labels: {
                    fontSize: 15
                }
            },
        }
    });
};