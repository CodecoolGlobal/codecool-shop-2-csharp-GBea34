const checkout = {
    button: function () {
        let checkoutButton = document.getElementById("checkout2");
        checkoutButton.addEventListener('click', event => { this.goToCheckout(); });

        let saveBtn = document.querySelector("#saveCart");
        saveBtn.addEventListener("click", saveCart);
    },
    goToCheckout: function () {
        location.href = "/checkout";
    }
}
checkout.button();

async function saveCart(event) {
    const package = event.target.dataset.products;
    await apiGet('/saveCart/?products=' + package);
    alert("Cart Saved");
}

async function apiGet(url) {
    let response = await fetch(url, {
        method: "GET",
    });
    if (response.ok) {
        return await response.json();
    }
}