function EFLVM() {
	this.CallApi = function () {
		$.ajax({
			type: "GET",
			url: '/api/Authentication/SendersMail',
			
			success: function () {
				alert("WE ARE SUCCESSFULL");
			},
			error: function (er) {
				
				alert("Something Went Wrong");
			},
			dataType: "json"
		});
	}
}
// Activates knockout.js
ko.applyBindings(new EFLVM());