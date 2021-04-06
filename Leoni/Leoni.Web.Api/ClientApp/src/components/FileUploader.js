import React, { useState } from "react"
import axios from "axios"
import { FormGroup, Label, Input, FormText, Button } from 'reactstrap';

export const FileUploader = () => {

    const [file, setFile] = useState();
    const [fileName, setFileName] = useState();

    const saveFile = (e) => {
        console.log(e.target.files[0])
        setFile(e.target.files[0])
        setFileName(e.target.files[0].name)
    }

    const uploadFile = async (e) => {
        const formData = new FormData();
        formData.append("Content", file);
        formData.append("Name", fileName);
        const res = await axios.post("https://localhost:5001/file", formData)
        console.log(res)
    }

    return (
        <>
        <FormGroup>
            <Label for="exampleFile">File</Label>
            <Input type="file" name="file" id="exampleFile" onChange={saveFile}/>
            <FormText color="muted">
            This is some placeholder block-level help text for the above input.
            It's a bit lighter and easily wraps to a new line.
            </FormText>
            <Button type="button" onClick={uploadFile}>Upload</Button>
         </FormGroup>
         </>
    )
}