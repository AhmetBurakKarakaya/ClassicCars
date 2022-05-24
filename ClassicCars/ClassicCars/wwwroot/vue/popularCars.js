
var popularCar = new Vue({
    el: "#popular",
    data: {
        popularCars: []
    },
    mounted: function () {
        this.getPopularCars();
    },
    methods: {
        getPopularCars: function () {
            var vm = this;
            $.ajax({ url: "/PopularCars/GetPopularCars", method: "POST" })
                .done(function (data) {
                    vm.popularCars = data.data;
                });
        }
    }

})
