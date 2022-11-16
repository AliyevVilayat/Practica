fetch('https://jsonplaceholder.typicode.com/photos')
  .then((response) => response.json())
  .then((data) => myMethod(data));

  function myMethod(data){

    for(let index = 0; index<16;index++){

        let card = document.createElement("div");

        card.style.width="18rem";
        card.classList.add("card");
        card.innerHTML=`<img class="card-img-top" src="..." alt="Card image cap">
        <div class="card-body">
            <h5 class="card-title">${data[index]["title"]}</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>`

        let cards_container = document.getElementById("cards_container");
        cards_container.append(card);
    }
  };
