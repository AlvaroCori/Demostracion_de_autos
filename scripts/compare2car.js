function redirectToMain(){
    window.location.href = `main.html`;
}
window.addEventListener('DOMContentLoaded',function(event){
    const baseUrl = 'http://localhost:3030/api';
    var queryParams = window.location.search.split('?');
    var carIds = queryParams[1].split('&');
    var car1= carIds[0].split('=')[1];
    var car2= carIds[1].split('=')[1];
    function fetchCar(id,idContainer)
    {
        const url = `${baseUrl}/carshow/${id}`;
        let status;
        fetch(url)
        .then((response) => { 
            status = response.status;
            return response.json();
        })
        .then((car) => {
            if(status == 200)
            {
                let carElements = ` <div class="image-car">
                                        <img src="${car.mainPhoto}">
                                    </div>
                                    <div id="car-feature">
                                        <h1>${car.name}</h1>
                                        <p>${car.typeCar}</p> 
                                        <p>${car.velocity}KM/H</p>
                                        <p>${car.date}</p>
                                        <p>${car.transmission}</p>
                                        <p>${car.typeEnergy}</p>
                                        <p>${car.country}</p>
                                    </div>
                                  `;
                document.getElementById(`${idContainer}`).innerHTML = carElements;
            } else {
                alert(car);
            }
        });
    }
    fetchCar(car1,"car1");
    fetchCar(car2,"car2");

    document.getElementById('redirect-to-main').addEventListener('click',redirectToMain);
});
/*http://127.0.0.1:5500/comparecar.html?car1Id=4&car2Id=8*/