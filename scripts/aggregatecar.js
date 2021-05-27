window.addEventListener('DOMContentLoaded',function(event){
    let teams = [];
    const baseUrl = 'http://localhost:3030/api';

    function RedirectToMain(){
        window.location="./main.html";
    } 

    function PostCar(event)
    {
        ///debugger;
        event.preventDefault();
        let url = `${baseUrl}/carshow`
        if(!event.currentTarget.name.value)
        {
            event.currentTarget.name.style.backgroundColor = 'red';
            return;
        }
        var data = {
            name: event.currentTarget.name.value,
            typeCar: event.currentTarget.typeCar.value,
            date: event.currentTarget.date.value,
            company: event.currentTarget.company.value,
            velocity: parseInt(event.currentTarget.velocity.value),
            transmission: event.currentTarget.transmission.value,
            typeEnergy: event.currentTarget.typeEnergy.value,
            country: event.currentTarget.country.value,
            mainPhoto: event.currentTarget.photo.value,
            description: event.currentTarget.description.value
        };
    
        fetch(url, {
            headers: { "Content-Type": "application/json; charset=utf-8" },
            method: 'POST',
            body: JSON.stringify(data)
        }).then(response => {
            if(response.status === 201){
                alert('El auto se agrego al evento.');
            } else {
                response.text()
                .then((error)=>{
                    alert(error);
                });
            }
        });
        
    }
    document.getElementById('create-car-frm').addEventListener('submit', PostCar);

    document.getElementById('redirect-to-main').addEventListener('click',RedirectToMain);
});