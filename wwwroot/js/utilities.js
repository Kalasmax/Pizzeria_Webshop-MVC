
// Hover "animation" för kundkorg
const cart_image = document.getElementById("navbar-cart");

cart_image.addEventListener('mouseenter', () => { increase(); });
function increase() {
    cart_image.style.width = "50px";
    cart_image.style.height = "45px";
    cart_image.style.margin = "-2.5px 0px -2.5px 1026.5px";

    return new Promise(resolve => {
        setTimeout(() => { resolve('resolved'); decrease(); }, 1500);
    });
}

cart_image.addEventListener('mouseleave', () => { decrease(); });
function decrease() {
    cart_image.style.width = "42.5px";
    cart_image.style.height = "40px";
    cart_image.style.margin = "0px 0px 0px 1030px";
}
// -------------------------------------------------------

//Ändrar "Lägg till i varukorg" till "Produkt tillagd" följt av antal produkter
document.querySelector("#ul-menu-y").addEventListener("click", function (e) {

    countProducts(e.target, document.getElementById("navbar-cart"));

    return new Promise(resolve => {
        setTimeout(() => { resolve('resolved'); increase(); }, 1500);
    });



});

function countProducts(source, target) {
    if (source.id === "button-addtocart" || source.id === "a-addtocart") {
        increase();
        if (source.innerText === "Lägg till i varukorg")
            source.innerHTML = "Produkt tillagd";
    }
}




//Ändrar "Lägg till i varukorg" till "Produkt tillagd" följt av antal produkter
//document.querySelector("#ul-menu-y").addEventListener("click", function (e) {
//    countProducts(e.target, e.target.innerText.charAt(e.target.innerText.length - 1));
//});

//function countProducts(source, target) {
//    var counter = parseInt(target);
//    if (source.id === "button-addtocart") {
//        increase();
//        if (source.innerText === "Lägg till i varukorg")
//            source.innerHTML = "Produkt tillagd";
//        else if (source.innerText.endsWith("d"))
//            source.innerHTML += " x 2";
//        else if (source.innerText.endsWith(target) >= "0" && source.innerText.endsWith(target) <= "9")
//            source.innerHTML = source.innerHTML.replace(target, (counter + 1).toString());
//    }
//}
// -------------------------------------------------------

// Vald "aktiv" kategori av mat i meny (HELT I ONÖDAN -.-)
//const navbar_menu = document.getElementById("navbar-menu-x");

//navbar_menu.addEventListener("click", (e) => {

//    const nav_buttons = (document.getElementsByClassName("nav-link"));

//    Array.from(nav_buttons).forEach(b => { b.removeAttribute("id", "active-category") });

//    //for(var i=0;i<nav_buttons.length;i++)
//    //{
//    //    nav_buttons[i].removeAttribute("id", "active-category")
//    //}

//    const nav_clicked = e.target;

//    nav_clicked.setAttribute("id", "active-category");
//});



