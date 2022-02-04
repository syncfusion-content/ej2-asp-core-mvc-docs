public IActionResult RowDropMethod([FromBody]DragDropData value)
        {
            var data = new CRUDModel();
            copyRecord = true;
            if (value.position == "bottomSegment" || value.position == "topSegment")
            {
                {
                    var childCount = 0;
                    int parent1 = (int)value.record.parentID;
                    childCount += FindChildRecords(parent1);
                    if (childCount == 1)
                    {
                        var i = 0;
                        for (; i < DataList.Count; i++)
                        {
                            if (DataList[i].taskID == parent1)
                            {
                                DataList[i].isParent = false;
                                break;
                            }
                            if (DataList[i].taskID == value.record.taskID)
                            {
                                DataList[i].parentID = null;
                                break;
                            }


                        }
                    }
                }
                DataList.Remove(DataList.Where(ds => ds.taskID == value.dragidMapping).FirstOrDefault());
                var j = 0;
                for (; j < DataList.Count; j++)
                {
                    if (DataList[j].taskID == value.dropidMapping)
                    {
                        value.record.parentID = DataList[j].parentID;
                        break;
                    }
                }

                data.Value = value.record;
                if (value.position == "bottomSegment")
                {
                    this.Insert(data, value.dropidMapping);
                }
                else if (value.position == "topSegment")
                {
                    this.InsertAtTop(data, value.dropidMapping);
                }
            }
            else if (value.position == "middleSegment")
            {
                DataList.Remove(DataList.Where(ds => ds.taskID == value.dragidMapping).FirstOrDefault());
                value.record.parentID = value.dropidMapping;
                FindDropdata(value.dropidMapping);
                data.Value = value.record;
                this.Insert(data, value.dropidMapping);
            }
            copyRecord = false;
            return Json(new { updatedRecords = value.record });
        }