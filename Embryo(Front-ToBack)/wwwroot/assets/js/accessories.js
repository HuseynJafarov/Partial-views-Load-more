"use strict"


$(function () {

    $(document).on("click", ".show-more a", function () {
        console.log("salam")
        //let parent = $("#parent-products")

        //let skipCount = $("#parent-products").children().length;

        //let productCount = $("#product-count").val();

        //$.ajax({
        //    /* url: `/accessories/loadmore?skip=${skipCount}`,*/
        //    url: "/accessories/loadmore",
        //    type: "Get",
        //    data: {
        //        skip: skipCount
        //    },
        //    success: function (res) {

        //        $(parent).append(res);

        //        skipCount = $("#parent-products").children().length;

        //        if (skipCount >= productCount) {

        //            $(".show-more button").addClass("d-none");

        //        }
        //    }
        //})
    });
    



});

let scrollSection = document.getElementById("scroll-section");

window.onscroll = function () {
    scrollFunction();
};

function scrollFunction() {
    if (
        document.body.scrollTop > 195 ||
        document.documentElement.scrollTop > 195
    ) {
        scrollSection.style.top = "0";
    } else {
        scrollSection.style.top = "-62px";
        $("div").removeClass("inActive");
    }
}

let basketBtns = document.querySelectorAll("#accessories .shop-icon");

let products = [];

if (localStorage.getItem("products") != null) {
  products = JSON.parse(localStorage.getItem("products"));
}

basketBtns.forEach((basketBtn) => {
  basketBtn.addEventListener("click", function (e) {
    e.preventDefault();

    let productImage =
      this.parentNode.previousElementSibling.lastElementChild.getAttribute("src");
    
    let productName = this.parentNode.firstElementChild.innerText;
    let productPrice = parseInt(this.nextElementSibling.innerText.substring(2));
    let productId = parseInt(
       this.parentNode.parentNode.getAttribute("data-id")
       );
      

    let existProduct = products.find((m) => m.id == productId);
    console.log(productId);

    if (existProduct != undefined) {
      existProduct.count += 1;
    } else {
      products.push({
        id: productId,
        name: productName,
        price:productPrice,
        image: productImage,
        count: 1,
      });
    }

    localStorage.setItem("products", JSON.stringify(products));
    document.querySelector("sup").innerText = getProductsCount(products);
  });
});

document.querySelector("sup").innerText = getProductsCount(products);

function getProductsCount(items) {
  let resultCount = 0;
  for (const item of items) {
    resultCount += item.count;
  }
  return resultCount;
}
  