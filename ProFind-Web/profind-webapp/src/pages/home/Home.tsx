import { PrimaryButton } from '@fluentui/react';
import React, { Fragment } from 'react';
import { Col, Container, Row } from 'react-bootstrap';

type HomeProps = {
    saludo: string,
    despedida: string,
};

const Home = ({ saludo, despedida }: HomeProps) => {
    return (
        <Container>
            <Row xs={2}>
                <Col>Col 1 of 1</Col>
                <Col>{saludo}</Col>

                <Col>Col 2 of 2</Col>
            </Row>
            <Row>
                <Col>{despedida}</Col>
                <Col>Col 1 of 3</Col>
                <Col>Col 2 of 3</Col>
                <Col>Col 3 of 3</Col>
            </Row>
        </Container>
    );
}

export { Home };