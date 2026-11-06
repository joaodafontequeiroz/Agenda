<script>

export default {

  data(){
    return{
      EverdadeiroLocal: this.Everdadeiro,
      mensagemLocal: this.mensagem,
    }
  },

  props: {
    Everdadeiro: Boolean,
    mensagem: String,
  },
  emits: ['update:opBlocoRetorno', 'update:opBlocoMenorExpandidoo'],
}
</script>

<template>

  <div v-if="EverdadeiroLocal" class="">
    <img class="" @click="$emit('update:opBlocoRetorno')" src="/fechar.png" alt="icone para fechar a aba">
    <img src="/acerto.jpg" alt="imagem que refere ao resultado esperado">
    <div>Tudo Certo!</div>
    <div>{{mensagemLocal}}</div>
    <div>Voce ja pode continuar</div>
    <button class="" type="button" @click="$emit('update:opBlocoRetorno'); $emit('update:opBlocoMenorExpandidoo', false)" ></button>
    <div>Tudo salvo. Pode seguir com tranquilidade.</div>
  </div>

  <div v-else class="">
    <img class="" @click="$emit('update:opBlocoRetorno')" src="/fechar.png" alt="icone para fechar a aba">
    <img src="/erro.jpg" alt="imagem que refere ao resultado errado">
    <div>Nao foi possivel salvar</div>
    <div>{{mensagemLocal}}</div>
    <div>Tente novamente em instantes</div>
    <button type="button" @click="$emit('update:opBlocoRetorno')"></button>
  </div>
</template>


<style scoped>

/* ===== FUNDO ESCURECIDO E POSICIONAMENTO ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) {
  position: fixed;
  inset: 0;
  width: 100vw !important;
  height: 100dvh;
  z-index: 9999;

  display: grid;
  grid-template-columns: minmax(0, min(440px, calc(100vw - 32px)));
  grid-template-rows:
    32px
    76px
    20px
    42px
    12px
    46px
    26px
    28px
    48px
    13px
    27px
    30px;

  place-content: center;
  text-align: center;
  background: rgba(30, 42, 37, 0.45);
  font-family: inherit;
  color: #202925;
  isolation: isolate;
}

/* ===== JANELA BRANCA CENTRAL ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
)::before {
  content: "";
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);

  width: min(440px, calc(100vw - 32px));
  height: 400px;
  background: #ffffff;
  border-radius: 20px;
  box-shadow: 0 12px 45px rgba(0, 0, 0, 0.13);
  z-index: 0;
}

/* Elementos ficam na frente do fundo branco */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > * {
  position: relative;
  grid-column: 1;
  z-index: 1;
  box-sizing: border-box;
}

/* ===== ÍCONE DE FECHAR ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > img:first-of-type {
  grid-row: 1;
  justify-self: end;
  align-self: start;

  width: 18px;
  height: 18px;
  margin-top: 24px;
  margin-right: 24px;

  object-fit: contain;
  opacity: 0.55;
  cursor: pointer;
  transition: opacity 0.2s;
}

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > img:first-of-type:hover {
  opacity: 1;
}

/* ===== ÍCONE CENTRAL DE RESULTADO ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > img:nth-of-type(2) {
  grid-row: 2;
  justify-self: center;
  align-self: center;

  width: 76px;
  height: 76px;
  padding: 15px;
  border-radius: 50%;
  object-fit: contain;
}

/* Fundo verde para sucesso */

div:has(> img[src="/acerto.jpg"]) > img:nth-of-type(2) {
  background: #e8f4ed;
}

/* Fundo vermelho para erro */

div:has(> img[src="/erro.jpg"]) > img:nth-of-type(2) {
  background: #fbefef;
}

/* ===== TÍTULO PRINCIPAL ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > div:nth-of-type(1) {
  grid-row: 4;
  align-self: center;
  justify-self: center;

  padding: 0 15px;
  font-size: 26px;
  font-weight: 500;
  line-height: 1.2;
  color: #202925;
}

/* ===== MENSAGEM VINDO DO BACKEND ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > div:nth-of-type(2) {
  grid-row: 6;
  align-self: center;
  justify-self: center;

  width: 100%;
  max-width: 400px;
  padding: 0 20px;
  font-size: 16px;
  font-weight: 400;
  line-height: 1.4;
  color: #77817c;
  overflow-wrap: anywhere;
}

/* ===== SEGUNDA LINHA DA MENSAGEM ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > div:nth-of-type(3) {
  grid-row: 7;
  align-self: center;
  justify-self: center;

  padding: 0 15px;
  font-size: 16px;
  line-height: 1.4;
  color: #77817c;
}

/* ===== BOTÃO PRINCIPAL ===== */

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > button {
  grid-row: 9;
  justify-self: center;
  align-self: center;

  display: flex;
  justify-content: center;
  align-items: center;

  width: calc(100% - 64px);
  height: 48px;

  border: none;
  border-radius: 10px;
  font-family: inherit;
  font-size: 16px;
  font-weight: 600;
  color: #ffffff;
  cursor: pointer;

  transition:
    background 0.2s ease,
    transform 0.2s ease;
}

:is(
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"])
) > button:hover {
  transform: translateY(-2px);
}

/* ===== MODAL DE SUCESSO ===== */

div:has(> img[src="/acerto.jpg"]) > button {
  background: #23805e;
}

div:has(> img[src="/acerto.jpg"]) > button:hover {
  background: #196a4d;
}

/* Texto do botão vazio */

div:has(> img[src="/acerto.jpg"]) > button::before {
  content: "Continuar";
}

/* Mensagem abaixo do botão */

div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(4) {
  grid-row: 11;
  align-self: center;
  justify-self: center;

  padding: 0 12px;
  font-size: 14px;
  color: #77817c;
}

/* ===== MODAL DE ERRO ===== */

div:has(> img[src="/erro.jpg"]) > button {
  background: #2d3933;
}

div:has(> img[src="/erro.jpg"]) > button:hover {
  background: #1d2923;
}

/* Texto do botão de erro */

div:has(> img[src="/erro.jpg"]) > button::before {
  content: "↻  Tentar novamente";
}

/* Texto abaixo do botão de erro */

div:has(> img[src="/erro.jpg"]) > button::after {
  content: "Voltar à página";
  position: absolute;
  top: calc(100% + 18px);
  left: 0;
  width: 100%;

  font-size: 14px;
  font-weight: 400;
  color: #77817c;
  text-align: center;
}

/* ===== RESPONSIVIDADE ===== */

@media (max-width: 480px) {
  :is(
    div:has(> img[src="/acerto.jpg"]),
    div:has(> img[src="/erro.jpg"])
  ) > div:nth-of-type(1) {
    font-size: 23px;
  }

  :is(
    div:has(> img[src="/acerto.jpg"]),
    div:has(> img[src="/erro.jpg"])
  ) > div:nth-of-type(2),
  :is(
    div:has(> img[src="/acerto.jpg"]),
    div:has(> img[src="/erro.jpg"])
  ) > div:nth-of-type(3) {
    font-size: 14px;
  }

  :is(
    div:has(> img[src="/acerto.jpg"]),
    div:has(> img[src="/erro.jpg"])
  ) > button {
    width: calc(100% - 40px);
  }
}

@media (max-height: 430px) {
  :is(
    div:has(> img[src="/acerto.jpg"]),
    div:has(> img[src="/erro.jpg"])
  ) {
    align-content: start;
    overflow-y: auto;
    padding-top: 16px;
    padding-bottom: 16px;
  }

  :is(
    div:has(> img[src="/acerto.jpg"]),
    div:has(> img[src="/erro.jpg"])
  )::before {
    top: 16px;
    transform: translateX(-50%);
  }
}

</style>

