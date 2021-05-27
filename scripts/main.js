function redirectToCar(carId){
    window.location.href = `specificcar.html?carId=${carId}`;
}
var elements = 0
var car1 = 0
var car2 = 0
function compareTwoCars(id){
    if (elements==0)
    {
        car1=id;
        elements =elements+1;
    }
    else{
        if (elements==1 && car1!=id)
        {
            car2=id;
            alert(`${car1} ${car2}`);
            window.location.href = `comparecar.html?car1Id=${car1}&car2Id=${car2}`;
            elements =0;
            car1 = 0;
            car2 = 0;
        }
    }
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
    function filterValues(ages){
        const unique = (value, index, self) => {
            return self.indexOf(value) === index
          }
          const uniqueAges = ages.filter(unique)
          
          console.log(uniqueAges)
          return uniqueAges
    }

    async function fetchTeams(event)
    {
        const url = `${baseUrl}/carshow`;
        let response = await fetch(url);
        try{
            if(response.status == 200){
                debugger;
                let data = await response.json();
                senseOfOrder = document.getElementById('order-type-sense').value;
                typeOfOrder = document.getElementById('order-type').value;
                descendent = senseOfOrder!="ascendent";
                data.sort((a, b) => {
                    if (descendent==false){
                        if(a[typeOfOrder] <= b[typeOfOrder]) return -1;
                        if(a[typeOfOrder] > b[typeOfOrder]) return 1;
                    }
                    if (descendent==true){
                        if(a[typeOfOrder] >= b[typeOfOrder]) return -1;
                        if(a[typeOfOrder] < b[typeOfOrder]) return 1;
                    }
                    return 0;
                })

                /*uniqueCompanies = filterValues(data.map(car => car.company));
                uniqueCountries = filterValues(data.map(car => car.country));*/
                uniqueTypeCar = filterValues(data.map(car => car.typeCar));
                
                let typeCars = uniqueTypeCar.map(value => {return `<option value=${value}>${value}</option>`});
                var typeCarsContent = `<select id="typeCars">${typeCars.join('')}</select>`;
                document.getElementById('filter-container').innerHTML = typeCarsContent;
/*
<select name="order-list-sense" id="order-type-sense">
            <option value="ascendent">ASCENDENTE</option> 
            <option value="descendent">DESCENDENTE</option>  
        </select>
*/
                let teamsLi = data.map( car => { return `<div>
                                                            <img src=${car.mainPhoto}>
                                                            <h2>${car.name}</h2> 
                                                            <div class="text-container">   
                                                                <p>Tipo: ${car.typeCar}</p>
                                                                <p>Compania: ${car.company}</p>
                                                                <p>Velocidad maxima: ${car.velocity}</p>
                                                                <p>Pais: ${car.country}</p>
                                                                <p>Fecha de creacion: ${car.date.split("T")[0]}</p>
                                                            </div>
                                                            <div class="button-container">
                                                                <button type="button" onclick="redirectToCar(${car.id})">VER AUTO</button>
                                                                <button type="button" data-delete-car-id="${car.id}">BORRAR</button>
                                                                <input type="checkbox" onclick="compareTwoCars(${car.id})">
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