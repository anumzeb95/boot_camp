
var countryStateInfo = {

    Afghanistan: [
      "Herat",
      "Kabul",
      "Kandahar",
      "Molah",
      "Rana",
      "Shar",
      "Sharif",
      "Wazir Akbar Khan"
   ], 
    
    Australia: [
      "Adelaide",
      "Brisbane",
      "Cambridge",
      "Canberra",
      "Hobart",
      "Melbourne",
      "Newcastle",
      "Perth",
      "Sydney",
      "Wollongong"
    ],
    
    Bangladesh: [
      "Bogra",
      "Barisal",
      "Chittagong",
      "Comilla",
      "Dhaka",
      "Khulna",
      "Mymensingh",
      "Narayanganj",
      "Sylhet",
      "Rajshahi",
      "Tongi"
    ],
    
    Canada: [
      "Calgar",
      "Montreal",
      "Niagara Falls",
      "Ottawa",
      "Quebec City",
      "Toronto",
      "Vancouver",
      "Victoria"
    ],
    
    China: [
      "Beijing",
      "Chengdu",
      "Chongqing",
      "Dongguan",
      "Guangzhou",
      "Shenzhen",
      "Shanghai",
      "Shenyang",
      "Tianjin",
      "Wuhan"
    ],
   
    India: [
      "Agra",
      "Bengaluru",
      "Delhi",
      "Goa",
      "Hyderabad",
      "Jaipur",
      "Manali",
      "Mumbai",
      "Ooty",
      "Pondicherry"
    ],
   
    Iran: [
      "Arak",
      "Isfahan",
      "Kashan",
      "Kerman",
      "Qeshm",
      "Shiraz",
      "Semnan",
      "Tehran",
      "Yazd"
    ],
   
    NewZealand: [
      "Auckland",
      "Christchurch",
      "Dunedin",
      "Napier-Hastings",
      "Nelson",
      "New Plymouth",
      "Rotorua",
      "Tauranga",
      "Whangarei",
      "Wellington"
    ],
   
    Pakistan: [
      "Abbottabad",
      "Faisalabad",
      "Gujranwala",
      "Islamabad",
      "Karachi",
      "Lahore",
      "Multan",
      "Peshawar",
      "Quetta",
      "Rawalpindi"
    ],

    Russia: [
      "Kazan",
      "Krasnodar",
      "Moscow",
      "Nizhny Novgorod",
      "Novosibirsk",
      "St Petersburg",
      "Sochi",
      "Smolensk",
      "Veliky Novgorod",
      "Vladivostok"
    ],
  
    Spain: [
      "Barcelona",
      "Bilbao",
      "Córdoba",
      "Granada",
      "Madrid",
      "Malaga",
      "Salamanca",
      "Seville",
      "Toledo",
      "Valencia"
    ],
    
    SriLanka: [
      "Badulla",
      "Colombo",
      "Dehiwala",
      "Eppawala",
      "Gampaha",
      "Homagama",
      "Matale",
      "Nugegoda",
      "Pannipitiya",
      "Peradeniya"
    ],
    
    Turkey: [
       "Antakya",
       "Antalya",
      "Ankara",
      "Bursa",
      "Fethiye",
      "Gaziantep",
      "Istanbul",
      "Izmir",
      "Konya",
      "Şanllurfa"
    ],
   
    UnitedArabEmirates: [
      "Abu Dhabi",
      "Al Ain",
      "Al Khan",
      "Ar Ruways",
      "As Satwah",
      "Dayrah",
      "Dubai",
      "Fujairah",
      "Ras al-Khaimah",
      "Sharjah"
    ],
    
    UnitedKingdom: [
      "Birmingham",
      "Bradford",
      "Bristol",
      "Edinburgh",
      "Leeds",
      "London",
      "Liverpool",
      "Manchester",
      "Nottingham",
      "Sheffield"
    ],
    
    UnitedStates: [
      "Boston",
      "California",
      "Chicago",
      "Florida",
      "Houston",
      "Las Vegas",
      "Los Angeles",
      "New York",
      "San Francisco",
      "Washington"
    ]
  }

  window.onload = function () {
    //todo: Get all input html elements from the DOM
  
    const countrySelection = document.querySelector("#country"),
      citySelection = document.querySelector("#city");

     // console.log(countrySelection);
     citySelection.disabled = true;
     citySelection.length = 1;//clear all selection/reset


     for(let country in countryStateInfo)
     {
      countrySelection.options[countrySelection.options.length] = new Option(
        country,country);

     }

     //conntry change

     countrySelection.onchange = (e) => {
      citySelection.disabled = false;
      citySelection.length = 1; //Clear all options from city Selection

    //city change
     
   citySelection.onchange = (e) => {
    citySelection.disabled = false;
    citySelection.length = 1; // remove all options bar first

   let city= countryStateInfo[countrySelection.value][e.target.value];
   
    for (let i=0; i< city.length; i++) {
      citySelection.options[citySelection.options.length] = new Option(
        city[i],
        city[i]
      );
    }
  };


    }
  }











    


  

