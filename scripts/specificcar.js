function RedirectToEditCar(carId){
    window.location.href = `editcar.html?carId=${carId}`;
}
window.addEventListener('DOMContentLoaded',function(event){
    const baseUrl = 'http://localhost:3030/api';
    var queryParams = window.location.search.split('?');
    var carId= queryParams[1].split('=')[1];
    document.getElementById("carId").textContent= carId;
    function fetchCar(id)
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
                let carElements = ` <div id="image-car">
                                        <img src="${car.mainPhoto}">
                                    </div>
                                    <div id="car-feature">
                                        <h1>Nombre: ${car.name}</h1>
                                        <p>Tipo: ${car.typeCar}</p> 
                                        <p>velocidad: ${car.velocity}</p>
                                        <p>fecha de creacion: ${car.date.split("T")[0]}</p>
                                        <p>Transmicion: ${car.transmission}</p>
                                        <p>Energia: ${car.typeEnergy}</p>
                                        <p>Pais: ${car.country}</p>
                                        <div id="description-car">
                                            <p>${car.description}</p>
                                        </div>
                                    </div>
                                  `;
                document.getElementById('specific-car-container').innerHTML = carElements;

                let buttonEdit = `<button type="button" onclick="RedirectToEditCar(${car.id})">EDITAR AUTO</button>`

                document.getElementById('button-id').innerHTML = buttonEdit;
            } else {
                alert(car);
            }
        });
    }
   
    fetchCar(carId);
 
});