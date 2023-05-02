dotnet new web
<button type="button" class="btn btn-danger" data-toggle="modal" data-target="#Modal1">PopUp</button>
<div class="modal" id="Modal1">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h2 class="modal-title">
                    Popup Diyalog Ekranı
                </h2>
            </div>
            <div class="modal-body">
                <table class="table table-bordered">
                    <tr>
                        <td>Veri 1</td>
                        <td>Veri 2</td>
                        <td>Veri 3</td>
                    </tr>
                    //Burada veri tabanına kayıtlı verileri çekiyoruz
                    @foreach (var x in Model)
                    {
                        <tr>
                            <td>@x.Veri1</td>
                            <td>@x.Veri2</td>
                            <td>@x.Veri3s</td>
                        </tr>
                    }
                </table>
                <button type="button" class="btn btn-danger" data-dismiss="modal">Tamam</button>
            </div>
        </div>
    </div>
</div>