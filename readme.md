things to improve


end date start from start date



<!--<input type="text" size="15" class="form-control" @ref="nameRef" placeholder="輸入姓名..." @bind="name"> -->


$('#output').pivot(
                        formatEvent(that.events),
                        {
                            rows: ["startDate","title","speaker"],
                            cols: ["gender","user"],
                            sorters: {
                                "gender": function(a,b){
                                  return a<b;
                                }
                            },
                        }
                    );       