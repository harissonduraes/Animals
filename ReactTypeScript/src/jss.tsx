import styled from '@emotion/styled';

export const Card = styled.div((

) => {

    return {
        border: '2px solid white',
        margin: '20px',
        textAlign: 'start',
        padding: '20px',

        maxWidth: '350px'

    }
})

export const Cards = styled.div((

) => {

    return {
        display: 'grid',
        // gridTemplateColumns: 'repeat(auto-fit, 100px)',
        gridTemplateColumns: 'auto auto auto',

        '@media (max-width: 1100px) ': {
            gridTemplateColumns: '1fr 1fr'
        },
        '@media (max-width: 600px) ': {
            gridTemplateColumns: '1fr'
        }
    }
})

export const Habilidades = styled.div((

) => {

    return {
        marginTop: '25px',
        display: 'grid',
        gridTemplateColumns: '1fr 1fr',
    }
})