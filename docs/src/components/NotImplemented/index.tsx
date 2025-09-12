import ReactRefAdmonition from '@site/src/components/ReactRefAdmonition';
import Admonition from '@theme/Admonition';

type Props = {
  href?: string
  name: string
}

export default function NotImplemented({ href, name }: Props) {
  return (
    <>
      <ReactRefAdmonition href={href} name={name}/>
      <Admonition type="danger" title="Not implemented yet">
        This API is not implemented in Feliz yet. Pull requests are welcome!
      </Admonition>
    </>
  );
}
