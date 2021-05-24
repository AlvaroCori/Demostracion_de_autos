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
                                        <p>Modelo: ${car.model}</p> 
                                        <p>velocidad: ${car.velocity}</p>
                                        <p>fecha de creacion: ${car.date}</p>
                                        <div id="description-car">
                                            <p>${car.description}</p>
                                        </div>
                                    </div>
                                  `;
                document.getElementById('specific-car-container').innerHTML = carElements;
            } else {
                alert(car);
            }
        });
    }
    function loadEdit(id){
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
                document.forms['edit-car-frm'].name.value = car.name;
                document.forms['edit-car-frm'].model.value = car.model;
                document.forms['edit-car-frm'].date.value = car.date.substring(0,10);
                document.forms['edit-car-frm'].company.value = car.company;
                document.forms['edit-car-frm'].velocity.value = parseInt(car.velocity);
                document.forms['edit-car-frm'].photo.value = car.mainPhoto;
                document.forms['edit-car-frm'].description.value = car.description;
            } else {
                alert(car);
            }
        });

    }
    function editElements(event){
        event.preventDefault();
        let url = `${baseUrl}/carshow/${carId}`;
        var data = {
            name: event.currentTarget.name.value,
            model: event.currentTarget.model.value,
            date: event.currentTarget.date.value,
            company: event.currentTarget.company.value,
            velocity: parseInt(event.currentTarget.velocity.value),
            mainPhoto: event.currentTarget.photo.value,
            description: event.currentTarget.description.value
        };
        fetch(url, {
        headers: { "Content-Type": "application/json; charset=utf-8" },
        method: 'PUT',
        body: JSON.stringify(data)
        }).then(response => {
            if(response.status === 200){
                alert('Se modificaron los campos.');
            } else {
                response.text()
                .then((error)=>{
                    alert(error);
                });
            }
        });

    }

    document.getElementById('edit-car-frm').addEventListener('submit', editElements);

    fetchCar(carId);
    loadEdit(carId);
});