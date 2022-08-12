import React from 'react';
import {
    DefaultButton,
} from '@fluentui/react';

import './App.css';
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import {Navbar} from "react-bootstrap";
import BasicExample from "./pages/brand";

function ContainerExample() {
    return (
        <Container fluid>
            <DefaultButton title={"Presionar"} text={"Presionar"}/>
        </Container>
    );
}

export const App: React.FunctionComponent = () => {
    return (
        <Container>
            <Row>
                <Navbar>
                    <BasicExample/>
                </Navbar>
            </Row>
            <Row>
                {ContainerExample()}
            </Row>
        </Container>
    );
};
