import React, { Component } from 'react';
import { Container, Button, Form, FormGroup, Label, Input, FormText,Row, Col } from 'reactstrap';

export class UploadFile extends Component {
  static displayName = UploadFile.name;

  render () {
    return (
      <Container fluid="sm">
        <Row>
          {/* <Col sm="12" md={{ size: 6, offset: 3 }}> */}
          <Col sm="12" md={{ size: 6 }}>
              <h1>Upload file!</h1>
              <Form>
                <FormGroup>
                  <Label for="exampleEmail">Email</Label>
                  <Input type="email" name="email" id="exampleEmail" placeholder="with a placeholder" />
                </FormGroup>
                <FormGroup>
                  <Label for="exampleText">Text Area</Label>
                  <Input type="textarea" name="text" id="exampleText" />
                </FormGroup>
                <FormGroup>
                  <Label for="exampleFile">File</Label>
                  <Input type="file" name="file" id="exampleFile" />
                  <FormText color="muted">
                    This is some placeholder block-level help text for the above input.
                    It's a bit lighter and easily wraps to a new line.
                  </FormText>
                </FormGroup>
                <FormGroup tag="fieldset">
                  <legend>Radio Buttons</legend>
                  <FormGroup check>
                    <Label check>
                      <Input type="radio" name="radio1" />{' '}
                      Option one is this and that—be sure to include why it's great
                    </Label>
                  </FormGroup>
                  <FormGroup check>
                    <Label check>
                      <Input type="radio" name="radio1" />{' '}
                      Option two can be something else and selecting it will deselect option one
                    </Label>
                  </FormGroup>
                </FormGroup>
                <FormGroup check>
                  <Label check>
                    <Input type="checkbox" />{' '}
                    Check me out
                  </Label>
                </FormGroup>
                <br></br>
                <Button >Submit</Button>
              </Form>
          </Col>
        </Row>
      </Container >
    );
  }
}
