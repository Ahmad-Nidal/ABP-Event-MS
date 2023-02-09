$(function () {
    var l = abp.localization.getResource('EMS');

    var dataTable = $('#EventsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(eMS.events.event.getList),
            columnDefs: [
                {
                    title: l('Title'),
                    data: "title"
                },
                {
                    title: l('Description'),
                    data: "description"
                },
                {
                    title: l('Location'),
                    data: "location",
                    render: function (data) {
                        return l('Enum:Location.' + data);
                    }
                },
                {
                    title: l('Date'),
                    data: "date",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
});
