function redirectToCar(carId){
    window.location.href = `specificcar.html?carId=${carId}`;
}
window.addEventListener('DOMContentLoaded',function(event){
    let teams = [];
    const baseUrl = 'http://localhost:3030/api';

    function DeleteTeam(event){
        ///debugger;
        let carId = this.dataset.deleteCarId;
        let url = `${baseUrl}/carshow/${carId}`;
        fetch(url, { 
        method: 'DELETE' 
        }).then((data)=>{
            if(data.status === 200){
                alert('deleted');
                location.reload();
            }
        }); 
    }
    function RedirectToAggregateCar(){
        window.location="./aggregatecar.html";
    } 

    async function fetchTeams(event)
    {
        const url = `${baseUrl}/carshow`;
        let response = await fetch(url);
        try{
            if(response.status == 200){
                debugger;
                let data = await response.json();
                data.sort((a, b) => {
                    if(a.name <= b.name) return -1;
                    if(a.name > b.name) return 1;
                
                    return 0;
                })
                console.log(document.getElementById('order-container').value)
                let teamsLi = data.map( car => { return `<div>
                                                            <img src=${car.mainPhoto}>
                                                            <h2>${car.name}<h2> 
                                                            <div class="text-container">   
                                                                <p>Modelo: ${car.model}</p>
                                                                <p>compania: ${car.company}</p>
                                                                <p>velocidad maxima: ${car.velocity}</p>
                                                                <p>fecha de creacion: ${car.date}</p>
                                                            </div>
                                                            <div class="button-container">
                                                                <button type="button" onclick="redirectToCar(${car.id})">VER AUTO</button>
                                                                <button type="button" data-delete-car-id="${car.id}">BORRAR</button>
                                                            </div>
                                                         </div>`});
                var teamContent = teamsLi.join('');
                document.getElementById('teams-container').innerHTML = teamContent;
                let buttons = document.querySelectorAll('#teams-container div button[data-delete-car-id]');
                for (const button of buttons) {
                    button.addEventListener('click', DeleteTeam);
                }
            } else {
                var errorText = await response.text();
                alert(errorText);
            }
        } catch(error){
            var errorText = await error.text();
            alert(errorText);
        }
    }
    
    document.getElementById('refresh-btn').addEventListener('click', fetchTeams);
    document.getElementById('redirect').addEventListener('click',RedirectToAggregateCar);
    document.getElementById('order-container').addEventListener('change',fetchTeams);
    fetchTeams();
});