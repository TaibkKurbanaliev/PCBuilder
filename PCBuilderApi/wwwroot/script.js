var Product = {
  Id: 0,
  Name: null,
  Description: null,
  CreatedDate: "0001-01-01T00:00:00",
  Cost: 0,
  CPU: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  GPU: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  MotherBoard: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  DRAM: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  PowerSupply: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  Case: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  PCColling: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  Storages: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  },
  Fans: {
    Name: null,
    Link: null,
    Count: 0,
    Cost: 0,
    Decription: null
  }
};


//Данные для отправки. Если работать не будет то попробуй  его в методе раскоментировать 
const xhr = new XMLHttpRequest();
const url = "/api/PC";

xhr.open("POST", url, true);
xhr.setRequestHeader("Content-Type", "application/json");

xhr.onreadystatechange = function () {
  if (xhr.readyState === 4 && xhr.status === 200) {
    const response = JSON.parse(xhr.responseText);
    console.log(response);
  }
};



//получаем дату
function getTodayDate() {
    const today = new Date();
    const options = { year: 'numeric', month: '2-digit', day: '2-digit' };
    return today.toLocaleDateString('en-US', options);
  }

  var dates=getTodayDate();

  function fillObjectElement(obj, key, value) {
    obj[key] = value;
  }


function fillProductElement(product, category, elementName, value) {
    // Проверяем, существует ли категория в объекте product
    if (!product.hasOwnProperty(category)) {
      product[category] = {};
    }
    // Заполняем элемент объекта
    product[category][elementName] = value;
  }

  function fillObj(Obj, ObjEl,Name,Link,Decription){
    fillProductElement(Product, ObjEl, 'Name', Name);
    fillProductElement(Product, ObjEl, 'Link', Link);
    fillProductElement(Product, ObjEl, 'Decription', Decription);
  }

  //конвертация в Json
 //const json=JSON.stringify(Product);

document.addEventListener('DOMContentLoaded', function() {
    
 
    var form = document.getElementById('form');
    form.addEventListener('submit', function(e) {
      e.preventDefault();

    //Название и описание
    var title=document.getElementById('Name').value;
    var description=document.getElementById('Description').value;

    //Input CPU
      var titleCPU = document.getElementById('titleCPU').value;
      var linkCPU = document.getElementById('linkCPU').value;
      var descriptionCPU = document.getElementById('descriptionCPU').value;

    //Input GPU
      var titleGPU= document.getElementById('titleGPU').value;
      var linkGPU = document.getElementById('linkGPU').value;
      var descriptionGPU = document.getElementById('descriptionGPU').value;


     //Input MotherBoard
      var titleMotherBoard = document.getElementById('titleMotherBoard').value;
      var linkMotherBoard = document.getElementById('linkMotherBoard').value;
      var descriptionMotherBoard = document.getElementById('descriptionMotherBoard').value;
       

       //Input Dram
      var titleDRAM = document.getElementById('titleDRAM').value;
      var linkDRAM = document.getElementById('linkDRAM').value;
      var descriptionDRAM= document.getElementById('descriptionDRAM').value;
    

      //PowerSupply
      var titlePowerSupply = document.getElementById('titlePowerSupply').value;
      var linkPowerSupply = document.getElementById('linkPowerSupply').value;
      var descriptionPowerSupply= document.getElementById('descriptionPowerSupply').value;  

      
      //Case
      var titleCase = document.getElementById('titleCase').value;
      var linkCase = document.getElementById('linkCase').value;
      var descriptionCase= document.getElementById('descriptionCase').value;  
      

     //PCColing
      var titlePCColing = document.getElementById('titlePCColing').value;
      var linkPCColing = document.getElementById('linkPCColing').value;
      var descriptionPCColing= document.getElementById('descriptionPCColing').value;  

      //Storages
      var titleStorages = document.getElementById('titleStorages').value;
      var linkStorages = document.getElementById('linkStorages').value;
      var descriptionStorages= document.getElementById('descriptionStorages').value;

      //Fans
      var titleFans = document.getElementById('titleFans').value;
      var linkFans = document.getElementById('linkFans').value;
      var descriptionFans= document.getElementById('descriptionFans').value;
      
      //Заполнение
      fillObj(Product,'CPU',titleCPU,linkCPU,descriptionCPU);
      fillObj(Product,'GPU',titleGPU,linkGPU,descriptionGPU);
      fillObj(Product,'MotherBoard',titleMotherBoard,linkMotherBoard,descriptionMotherBoard);
      fillObj(Product,'DRAM',titleDRAM,linkDRAM,descriptionDRAM);
      fillObj(Product,'PowerSupply',titlePowerSupply,linkPowerSupply,descriptionPowerSupply);
      fillObj(Product,'Case',titleCase,linkCase,descriptionCase);
      fillObj(Product,'PCColing',titlePCColing,linkPCColing,descriptionPCColing);
      fillObj(Product,'Storages',titleStorages,linkStorages,descriptionStorages);
      fillObj(Product,'Fans',titleFans,linkFans,descriptionFans);



      //Добавляем дату
      fillObjectElement(Product,'CreatedDate',dates);

      //Добавляем название и описание (первая форма)
      fillObjectElement(Product,'Name',title);
      fillObjectElement(Product,'Description',description);
      console.log(Product);
      
      
      xhr.send(JSON.stringify(Product));  Раскоментрируешь




     

      //Если не будет работать то здесь раскоментируешь
      /*const xhr = new XMLHttpRequest();
        const url = "/api/PC";

        xhr.open("POST", url, true);
        xhr.setRequestHeader("Content-Type", "application/json");

        xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            const response = JSON.parse(xhr.responseText);
            console.log(response);
        }
        };
        xhr.send(JSON.stringify(Product));*/

    });
  })