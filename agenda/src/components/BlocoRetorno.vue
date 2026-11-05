<script>

export default {

  data(){
    return{
    }
  },

  props: {
    Everdadeiro: Boolean,
    mensagem: String,
  },
  emits: ['update:opBlocoRetorno'],
}
</script>

<template>

  <div v-if="Everdadeiro" class="">
    <img class="" @click="$emit('update:opBlocoRetorno')" src="/fechar.png" alt="icone para fechar a aba">
    <img src="/acerto.jpg" alt="imagem que refere ao resultado esperado">
    <div>Tudo Certo!</div>
    <div>{{mensagem}}</div>
    <div>Voce ja pode continuar</div>
    <button class="" type="button" @click="$emit('update:opBlocoRetorno')" ></button>
    <div>Tudo salvo. Pode seguir com tranquilidade.</div>
  </div>

  <div v-else class="">
    <img class="" @click="$emit('update:opBlocoRetorno')" src="/fechar.png" alt="icone para fechar a aba">
    <img src="/erro.jpg" alt="imagem que refere ao resultado errado">
    <div>{{mensagem}}</div>
    <div>Tente novamente em instantes</div>
    <button type="button" @click="$emit('update:opBlocoRetorno')"></button>
  </div>
</template>

<style scoped>
/* =====================================
   ESTRUTURA PRINCIPAL DOS DOIS MODAIS
   ===================================== */

div:has(> img[src="/acerto.jpg"]),
div:has(> img[src="/erro.jpg"]) {
  position: fixed;
  inset: 0;
  margin: auto;

  width: 440px;
  max-width: calc(100vw - 32px);
  height: 400px;
  max-height: calc(100dvh - 32px);

  background-color: #ffffff;
  border-radius: 20px;
  padding: 32px;
  box-sizing: border-box;

  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;

  z-index: 9999;
  isolation: isolate;

  box-shadow: 0 20px 60px rgba(0, 0, 0, 0.2);

  animation: aparecerModal 0.3s ease-out;
}


/* =====================================
   FUNDO ESCURECIDO SOBRE A TELA
   ===================================== */

div:has(> img[src="/acerto.jpg"])::before,
div:has(> img[src="/erro.jpg"])::before {
  content: "";
  position: fixed;
  inset: 0;

  background-color: rgba(15, 25, 20, 0.45);
  backdrop-filter: blur(2px);

  z-index: -1;
}


/* =====================================
   ICONE X PARA FECHAR
   ===================================== */

div:has(> img[src="/acerto.jpg"]) > img[src="/fechar.png"],
div:has(> img[src="/erro.jpg"]) > img[src="/fechar.png"] {
  position: absolute;
  top: 22px;
  right: 22px;

  width: 20px;
  height: 20px;
  object-fit: contain;

  cursor: pointer;
  opacity: 0.65;

  transition: opacity 0.2s, transform 0.2s;
}

div:has(> img[src="/acerto.jpg"]) > img[src="/fechar.png"]:hover,
div:has(> img[src="/erro.jpg"]) > img[src="/fechar.png"]:hover {
  opacity: 1;
  transform: scale(1.15);
}


/* =====================================
   ICONE DE SUCESSO
   ===================================== */

img[src="/acerto.jpg"] {
  width: 76px;
  height: 76px;

  padding: 18px;
  box-sizing: border-box;

  background-color: #e8f4ed;
  border-radius: 50%;

  object-fit: contain;
  mix-blend-mode: multiply;

  margin-bottom: 22px;
}


/* =====================================
   ICONE DE ERRO
   ===================================== */

img[src="/erro.jpg"] {
  width: 76px;
  height: 76px;

  padding: 18px;
  box-sizing: border-box;

  background-color: #fceeee;
  border-radius: 50%;

  object-fit: contain;
  mix-blend-mode: multiply;

  margin-bottom: 22px;
}


/* =====================================
   TITULO DE SUCESSO - TUDO CERTO!
   ===================================== */

div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(1) {
  font-size: 27px;
  font-weight: 500;
  color: #202925;

  line-height: 1.3;
  margin-bottom: 14px;
}


/* =====================================
   MENSAGEM RETORNADA DO BACK - SUCESSO
   ===================================== */

div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(2) {
  font-size: 16px;
  font-weight: 400;
  color: #7a8580;

  line-height: 1.5;
  margin-bottom: 4px;
}


/* =====================================
   TEXTO - VOCE JA PODE CONTINUAR
   ===================================== */

div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(3) {
  font-size: 16px;
  color: #7a8580;
  line-height: 1.5;
}


/* =====================================
   BOTAO VERDE - CONTINUAR
   ===================================== */

div:has(> img[src="/acerto.jpg"]) > button {
  width: 100%;
  min-height: 50px;

  margin-top: auto;
  padding: 12px 20px;

  background-color: #247f5e;
  border: none;
  border-radius: 10px;

  color: white;
  font-size: 16px;
  font-weight: 600;

  cursor: pointer;

  transition: background-color 0.2s, transform 0.2s;
}

div:has(> img[src="/acerto.jpg"]) > button::after {
  content: "Continuar";
}

div:has(> img[src="/acerto.jpg"]) > button:hover {
  background-color: #196b4e;
  transform: translateY(-2px);
}


/* =====================================
   RODAPE DO SUCESSO
   ===================================== */

div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(4) {
  font-size: 14px;
  color: #7a8580;

  margin-top: 16px;
}


/* =====================================
   MENSAGEM DE ERRO
   ===================================== */

div:has(> img[src="/erro.jpg"]) > div:nth-of-type(1) {
  font-size: 27px;
  font-weight: 500;
  color: #202925;

  line-height: 1.3;
  margin-bottom: 14px;
}


/* =====================================
   TEXTO - TENTE NOVAMENTE
   ===================================== */

div:has(> img[src="/erro.jpg"]) > div:nth-of-type(2) {
  font-size: 16px;
  font-weight: 400;
  color: #7a8580;

  line-height: 1.5;
}


/* =====================================
   BOTAO ESCURO - TENTAR NOVAMENTE
   ===================================== */

div:has(> img[src="/erro.jpg"]) > button {
  width: 100%;
  min-height: 50px;

  margin-top: auto;
  padding: 12px 20px;

  background-color: #2e3934;
  border: none;
  border-radius: 10px;

  color: #ffffff;
  font-size: 16px;
  font-weight: 600;

  cursor: pointer;

  transition: background-color 0.2s, transform 0.2s;
}

div:has(> img[src="/erro.jpg"]) > button::after {
  content: "Tentar novamente";
}

div:has(> img[src="/erro.jpg"]) > button:hover {
  background-color: #1c2822;
  transform: translateY(-2px);
}


/* =====================================
   ANIMACAO DE ENTRADA
   ===================================== */

@keyframes aparecerModal {
  from {
    opacity: 0;
    scale: 0.95;
  }

  to {
    opacity: 1;
    scale: 1;
  }
}


/* =====================================
   RESPONSIVIDADE
   ===================================== */

@media (max-width: 480px) {
  div:has(> img[src="/acerto.jpg"]),
  div:has(> img[src="/erro.jpg"]) {
    width: calc(100vw - 32px);
    height: 360px;
    padding: 28px 22px;
    border-radius: 16px;
  }

  div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(1),
  div:has(> img[src="/erro.jpg"]) > div:nth-of-type(1) {
    font-size: 23px;
  }

  div:has(> img[src="/acerto.jpg"]) > div:nth-of-type(2),
  div:has(> img[src="/erro.jpg"]) > div:nth-of-type(2) {
    font-size: 14px;
  }
}
</style>
