
var headCar = new Vue({
    el: "#home",
    data: {
        headCars: {
            id: null,
            title: null,
            tumbnail: null,
            isActive:null
        }
    },
    mounted: function () {
        this.getirHeadCars();
    },
    methods: {
        getirHeadCars: function () {
            var vm = this;
            $.ajax({ url: "/HeadCars/GetHeadCars", method: "POST" })
                .done(function (data) {
                    vm.headCars.id = data.data[0].id;
                    vm.headCars.title = data.data[0].title;
                    vm.headCars.tumbnail = data.data[0].tumbnail;
                    vm.headCars.isActive = data.data[0].isActive;
                });
        }
    }

})
